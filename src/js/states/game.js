var gameState = {
    init: function() {
        this.logger = new logger("gameState");
        this.logger.d("init");
    },
    preload: function() {
    },
    create: function() {
        var polygons = [];
        polygons.push([[-1,-1],[game.width+1,-1],[game.width+1,game.height+1],[-1,game.height+1]]);
        var light = new Light(game, 0, 0, polygons);
        light.create();
    },
    update: function() {},
};
