module app.example {
    'use strict';

    interface IExampleViewModel {
        examples: app.domain.IExample[];
    }

    class ExampleController implements IExampleViewModel {

        static $inject: string[] = ['app.services.repositories.ExampleRepository'];
        constructor(private exampleRepository: app.services.repositories.IExampleRepository,
            public examples: app.domain.IExample[]) {
            var vm = this;

            exampleRepository.context.query((data: app.domain.IExample[]) => {
                vm.examples = data;
            });
        }
    }

    angular
        .module('app.example')
        .controller('app.example.ExampleController',
            ExampleController);
} 