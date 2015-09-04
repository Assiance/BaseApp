var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var app;
(function (app) {
    var services;
    (function (services) {
        var repositories;
        (function (repositories) {
            'use strict';
            var ExampleRepository = (function (_super) {
                __extends(ExampleRepository, _super);
                function ExampleRepository($resource) {
                    _super.call(this);
                    this.$resource = $resource;
                    this.context = this.$resource('api/examples/:exampleId');
                }
                return ExampleRepository;
            })(repositories.BaseRepository);
            factory.$inject = ['$resource'];
            function factory($resource) {
                return new ExampleRepository($resource);
            }
            angular
                .module('app.services')
                .factory('app.services.repositories.ExampleRepository', factory);
        })(repositories = services.repositories || (services.repositories = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=example.repository.js.map