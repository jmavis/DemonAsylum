var game = new Phaser.Game(1024, 1024, Phaser.AUTO, 'gameDiv');

game.state.add('startup', startupState);
game.state.start('startup');
