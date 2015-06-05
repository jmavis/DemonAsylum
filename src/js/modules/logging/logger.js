var logger = function(name) {
    return {
        d: function(log) {
            console.log(name+": "+log);
        }
    }
}
