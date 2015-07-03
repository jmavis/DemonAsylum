/**
 * Base wall object.
 *
 * Treated as a filled polygon.
 *
 * Polygon based off of http://www.emanueleferonato.com/2015/02/03/play-with-light-and-dark-using-ray-casting-and-visibility-polygons/
 */
/**
 * @param game
 * @param points Array of [x,y] pairs
 */
Wall = function(game, points) {
    this.game = game;
    this._points = points;
};

Wall.prototype = {
    create: function() {
        this.logger = new logger("Wall");
        this.logger.d("create");

    },

    update: function() {
    },
};
