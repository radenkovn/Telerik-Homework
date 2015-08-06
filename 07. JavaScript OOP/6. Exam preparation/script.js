function solve() {
    var audio,
        video,
        playable,
        CONSTANTS,
        playlist,
        player,
        validator;
    CONSTANTS = {
        MIN_NAME_LENGTH: 3,
        MAX_NAME_LENGTH: 25,
        MIN_AUDIO_LENGTH: 0,
        MIN_IMDB_RATING: 1,
        MAX_IMDB_RATING: 5
    };
    validator = {
        validateIfUndefined: function (value, property) {
            if (typeof (value) === 'undefined') {
                throw  new Error(property + ' is undefined');
            }
        },
        validateIfString: function (value, property) {
            if (typeof (value) !== 'string') {
                throw  new Error(property + ' is not a string');
            }
        },
        validateIfNumber: function (value, property) {
            if (isNaN(value)) {
                throw new Error(property + ' is not a number');
            }
        },
        validateNames: function (name, property, minLength, maxLength) {
            minLength = minLength || CONSTANTS.MIN_NAME_LENGTH;
            maxLength = maxLength || CONSTANTS.MAX_NAME_LENGTH;
            this.validateIfUndefined(name, property);
            this.validateIfString(name, property);
            if (name.length < minLength || name.length > maxLength) {
                throw new Error('The length of ' + property + ' cannot be less than ' + minLength + ' or greater than ' + maxLength);
            }
        },
        validateAudioLength: function (length, property, minLength) {
            minLength = minLength || CONSTANTS.MIN_AUDIO_LENGTH;
            this.validateIfUndefined(length, property);
            this.validateIfNumber(length);
            length = +length;
            if (length <= minLength) {
                throw  new Error('The length of the ' + property + ' cannot be less than or equal to' + minLength);
            }
        },
        validateVideoimdbRating: function (rating, property, minValue, maxValue) {
            minValue = minValue || CONSTANTS.MIN_IMDB_RATING;
            maxValue = maxValue || CONSTANTS.MAX_IMDB_RATING;
            this.validateIfUndefined(rating, property);
            this.validateIfNumber(rating, property);
            rating = +rating;
            if (rating < minValue || rating > maxValue) {
                throw new Error('The ' + property + ' cannot be less than ' + minValue + ' or greater than ' + maxValue);
            }

        },
        validateIfPlayable: function (playable, property) {
            property = property || 'playable';
            this.validateIfUndefined(playable, property);
            if (playable.id === undefined) {
                throw  new Error('This is not a ' + property);
            }
        },
        validatePageAndSize: function (page, size, count) {
            this.validateIfUndefined(page, 'Page');
            this.validateIfUndefined(size, 'Size');
            this.validateIfNumber(page, 'Page');
            this.validateIfNumber(size, 'Size');
            if (page < 0) {
                throw new Error('The page is less than 0');
            }
            if (size <= 0) {
                throw new Error('The size is less than or equal to 0');
            }
            if (page * size > count) {
                throw new Error('That page is outside the bounds of the playlist!');
            }
        }
    };
    playable = (function () {
        var currentID = 0,
            playable = Object.create({});
        Object.defineProperties(playable, {
            'init': {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = currentID += 1;
                    return this;
                }
            },
            'title': {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    validator.validateNames(value, 'Title');
                    this._title = value;
                }
            },
            'author': {
                get: function () {
                    return this._author;
                },
                set: function (value) {
                    validator.validateNames(value, 'Author');
                    this._author = value;
                }
            },
            'id': {
                get: function () {
                    return this._id;
                }
            },
            'play': {
                value: function () {
                    return this.id + '. ' + this.title + this.author;
                }
            }
        });
        return playable;
    }());

    audio = (function (parent) {
        var audio = Object.create(parent);
        Object.defineProperties(audio, {
            'init': {
                value: function (title, author, length) {
                    Object.create(parent).init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            },
            'length': {
                get: function () {
                    return this._length;
                },
                set: function (value) {
                    validator.validateAudioLength(value, 'Audio');
                    this._length = value;
                }
            },
            'play': {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.length;
                }
            }
        });
        return audio;
    }(playable));

    video = (function (parent) {
        var video = Object.create(parent);
        Object.defineProperties(video, {
            'init': {
                value: function (title, author, imdbRating) {
                    Object.create(parent).init.call(this, title, author);
                    this.length = imdbRating;
                    return this;
                }
            },
            'imdbRating': {
                get: function () {
                    return this._imdbRating;
                },
                set: function (value) {
                    validator.validateVideoimdbRating(value, 'IMDB rating');
                    this._imdbRating = value;
                }
            },
            'play': {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            }
        });
        return video;
    }(playable));

    playlist = (function () {
        var currentID = 0;
        playlist = Object.create({});
        Object.defineProperties(playlist, {
            'init': {
                value: function (name) {
                    this.name = name;
                    this._id = currentID += 1;
                    this._playables = [];
                    return this;
                }
            },
            'name': {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateNames(value, 'Name');
                    this._name = value;
                }
            },
            'id': {
                get: function () {
                    return this._id;
                }
            },
            'addPlayable': {
                value: function (playable) {
                    validator.validateIfPlayable(playable);
                    this._playables.push(playable);
                    return this;
                }
            },
            'getPlayableById': {
                value: function (id) {
                    var i,
                        length,
                        property = 'ID';
                    validator.validateIfUndefined(id, property);
                    validator.validateIfNumber(id, property);
                    for (i = 0, length = this._playables.length; i < length; i += 1) {
                        if (this._playables[i].id === id) {
                            return this._playables[i];
                        }
                    }
                    return null;
                }
            },
            'removePlayable': {
                value: function (id) {
                    var i,
                        index,
                        length,
                        foundInPlaylist = false,
                        property = 'ID';
                    validator.validateIfUndefined(id, property);
                    if (typeof (id) === 'object' && id.id !== undefined) {
                        id = id.id;
                    }
                    for (i = 0, length = this._playables.length; i < length; i += 1) {
                        if (this._playables[i].id === id) {
                            foundInPlaylist = true;
                            index = i;
                            break;
                        }
                    }
                    if (foundInPlaylist) {
                        this._playables.splice(index, 1);
                    }
                    else {
                        throw new Error('A playable with the provided ID was not found');
                    }
                }
            },
            'listPlayables': {
                value: function (page, size) {
                    var playable = this._playables.slice(),
                        length = playable.length;
                    validator.validatePageAndSize(page, size, length);
                    return playable.splice(page * size, size);
                }
            },
            'playables': {
                get: function () {
                    return this._playables.slice();
                }
            }
        });
        return playlist;
    }());

    player = (function () {
        var currentID = 0;
        player = Object.create({});
        Object.defineProperties(player, {
            'init': {
                value: function (name) {
                    this.name = name;
                    this._id = currentID += 1;
                    this._playlists = [];
                    return this;
                }
            },
            'name': {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateNames(value, 'Name');
                    this._name = value;
                }
            },
            'id': {
                get: function () {
                    return this._id;
                }
            },
            'addPlaylist': {
                value: function (playlist) {
                    validator.validateIfPlayable(playlist);
                    this._playlists.push(playlist);
                    return this;
                }
            },
            'getPlaylistById': {
                value: function (id) {
                    var i,
                        length,
                        property = 'ID';
                    validator.validateIfUndefined(id, property);
                    validator.validateIfNumber(id, property);
                    for (i = 0, length = this._playlists.length; i < length; i += 1) {
                        if (this._playlists[i].id === id) {
                            return this._playlists[i];
                        }
                    }
                    return null;
                }
            },
            'removePlaylist': {
                value: function (id) {
                    var i,
                        index,
                        length,
                        foundInPlaylist = false,
                        property = 'ID';
                    validator.validateIfUndefined(id, property);
                    if (typeof (id) === 'object' && id.id !== undefined) {
                        id = id.id;
                    }
                    for (i = 0, length = this._playlists.length; i < length; i += 1) {
                        if (this._playlists[i].id === id) {
                            foundInPlaylist = true;
                            index = i;
                            break;
                        }
                    }
                    if (foundInPlaylist) {
                        this._playlists.splice(index, 1);
                    }
                    else {
                        throw new Error('A playlist with the provided ID was not found');
                    }
                    return this;
                }
            },
            'listPlaylists': {
                value: function (page, size) {
                    var playlist = this._playlists.slice(),
                        length = playlist.length;
                    validator.validatePageAndSize(page, size, length);
                    playlist.splice(page * size, size);
                    return playlist;
                }
            },
            'contains': {
                value: function (playable, playlist) {
                    validator.validateIfUndefined(playable, 'Playable');
                    validator.validateIfUndefined(playlist, 'Playlist');
                    validator.validateIfPlayable(playable, 'Playable');
                    validator.validateIfPlayable(playlist, 'Playlist');
                    return playlist.some(function (play) {
                        return playable.id === play.id;
                    });
                }
            },
            'search': {
                value: function (pattern) {
                    return this._playlists.slice().filter(function (playables) {
                        return playables.playables.some(function (playable) {
                            return playable.name.toLowerCase().indexOf(pattern.toLowerCase()) > 0;
                        })
                    }).map(function (playlist) {
                        return {
                            id: playlist.id,
                            name: playlist.name
                        }
                    });
                }
            }
        });
        return player;
    }());

    var module = {
        getPlayer: function (name) {
            return Object.create(player).init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating);
        }
    };
    return module;
}


