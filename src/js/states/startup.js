var startupState = {
    init: function() {
        this.logger = new logger("startUp");
        this.logger.d("init startup");
        this.scale.scaleMode = Phaser.ScaleManager.SHOW_ALL;
        this.scale.pageAlignHorizontally = true;
        this.scale.pageAlignVertically = true;
        this.scale.setScreenSize(true);
    },
    preload: function() {
    },
    create: function() {
        game.stage.backgroundColor = '#223';
    },
    update: function() {},
};
