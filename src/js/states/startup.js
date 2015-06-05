var startupState = {
    init: function() {
        this.logger = new logger("startUpState");
        this.logger.d("init");
        this.scale.scaleMode = Phaser.ScaleManager.SHOW_ALL;
        this.scale.pageAlignHorizontally = true;
        this.scale.pageAlignVertically = true;
        this.scale.setScreenSize(true);
    },
    preload: function() {
    },
    create: function() {
        game.stage.backgroundColor = '#223';
        game.state.start(States.game);
    },
    update: function() {},
};
