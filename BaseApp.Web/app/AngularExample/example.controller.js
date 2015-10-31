var app;
(function (app) {
    var example;
    (function (example) {
        'use strict';
        var ExampleController = (function () {
            function ExampleController(context, examples) {
                this.context = context;
                this.examples = examples;
                var vm = this;
                context.examples().query(function (data) {
                    vm.examples = data;
                });
            }
            ExampleController.$inject = ['app.services.ContextService'];
            return ExampleController;
        })();
        angular
            .module('app.example')
            .controller('app.example.ExampleController', ExampleController);
    })(example = app.example || (app.example = {}));
})(app || (app = {}));
//# sourceMappingURL=example.controller.js.map