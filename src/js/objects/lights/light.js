/**
 * Base light object.
 *
 * Is centered at a point and when rendered will generate a canvas around it for the light source.
 *
 * Right now it is only rendered on creation. When moving objects are added we will need to re-render on update.
 *
 *
 * Based off of http://www.emanueleferonato.com/2015/02/03/play-with-light-and-dark-using-ray-casting-and-visibility-polygons/
 */
Floor = function(game, xPos, yPos, polygons) {
    this.game = game;
    this._x = xPos;
    this._y = yPos;
    this._polygons = polygons;
};

Floor.prototype = {
    create: function() {
        this.logger = new logger("Light");
        this.logger.d("create");

        this._lightCanvas = game.add.graphics(this._x, this._y);

        this._renderLightPolygon();
    },

    _renderLightPolygon: function() {
        var visibility = this._generateLightPolygon(this._x, this._y, this._polygons);
        this._lightCanvas.clear();
        this._lightCanvas.lineStyle(2, 0xff8800, 1);
        this._lightCanvas.beginFill(0xffff00);
        this._lightCanvas.moveTo(visibility[0][0],visibility[0][1]);
        for(var i=1;i<=visibility.length;i++){
            this._lightCanvas.lineTo(visibility[i%visibility.length][0],visibility[i%visibility.length][1]);
        }
        this._lightCanvas.endFill();
    },

    _generateLightPolygon: function(x, y, polygons) {
        var segments = VisibilityPolygon.convertToSegments(polygons);
        segments = VisibilityPolygon.breakIntersections(segments);
        var position = [x, y];
        if (VisibilityPolygon.inPolygon(position, polygons[polygons.length-1])) {
            return VisibilityPolygon.compute(position, segments);
        }
        return null;
    },

    update: function() {
    },
};
