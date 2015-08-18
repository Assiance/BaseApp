module app.domain {
    'use strict';

    export interface IExample {
        exampleId: number;
        title: string;
    }

    export class Example implements IExample {

        constructor(public exampleId: number,
            public title: string) {

        }
    }
} 