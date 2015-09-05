module app.domain {
    'use strict';

    // Todo: Change to lowercase props
    export interface IExampleDefinition {
        Id: number;
        FirstName: string;
    }

    export interface IExample extends IExampleDefinition, ng.resource.IResource<app.domain.IExample> {
    }

    export class Example implements IExampleDefinition {
        public Id: number;

        constructor(public FirstName: string) {

        }
    }
} 