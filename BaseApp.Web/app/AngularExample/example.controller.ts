module app.example {
    'use strict';

    interface IExampleViewModel {
        examples: app.domain.IExample[];
    }

    class ExampleController implements IExampleViewModel {

        static $inject: string[] = ['app.services.ContextService'];
        constructor(private context: app.services.IContextService,
            public examples: app.domain.IExample[]) {
            var vm = this;

            context.examples().query((data: app.domain.IExample[]) => {
                vm.examples = data;
            });
        }
    }

    angular
        .module('app.example')
        .controller('app.example.ExampleController',
            ExampleController);
} 