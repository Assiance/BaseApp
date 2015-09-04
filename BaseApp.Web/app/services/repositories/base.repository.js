var app;
(function (app) {
    var services;
    (function (services) {
        var repositories;
        (function (repositories) {
            'use strict';
            var BaseRepository = (function () {
                function BaseRepository() {
                }
                return BaseRepository;
            })();
            repositories.BaseRepository = BaseRepository;
        })(repositories = services.repositories || (services.repositories = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=base.repository.js.map