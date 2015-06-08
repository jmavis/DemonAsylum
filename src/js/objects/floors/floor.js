Floor = function(game, points) {
    this.game = game;
    this._points = points;
};

Floor.prototype = {
    create: function() {
        this.logger = new logger("Floor");
        this.logger.d("create");

    },

    update: function() {
    },
};
