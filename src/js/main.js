var game = new Phaser.Game(512, 1024, Phaser.AUTO, 'gameDiv');

game.state.add(States.startup, startupState);
game.state.add(States.game, gameState);
game.state.start(States.startup);
