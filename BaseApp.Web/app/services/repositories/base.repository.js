var app;
(function (app) {
    var services;
    (function (services) {
        var repositories;
        (function (repositories) {
            'use strict';
            var BaseRepository = (function () {
                function BaseRepository(dataAccessService) {
                    this.dataAccessService = dataAccessService;
                }
                BaseRepository.prototype.query = function (params, data, success, error) {
                    return this.context.query(params, data, success, error);
                };
                BaseRepository.prototype.get = function (params, data, success, error) {
                    return this.context.get(params, data, success, error);
                };
                BaseRepository.prototype.save = function (params, data, success, error) {
                    return this.context.save(params, data, success, error);
                };
                BaseRepository.prototype.delete = function (params, data, success, error) {
                    return this.context.delete(params, data, success, error);
                };
                BaseRepository.prototype.remove = function (params, data, success, error) {
                    return this.context.remove(params, data, success, error);
                };
                return BaseRepository;
            })();
            repositories.BaseRepository = BaseRepository;
        })(repositories = services.repositories || (services.repositories = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=base.repository.js.map