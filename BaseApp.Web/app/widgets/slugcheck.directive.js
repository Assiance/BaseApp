(function () {
    'use strict';
    angular
        .module('app.widgets')
        .directive('blSlugCheck', slugCheck);
    function slugCheck() {
        var directive = {
            restrict: 'A',
            link: link
        };
        function link(scope, element) {
            element.on('blur', function () {
            });
        }
        return directive;
    }
})();
//# sourceMappingURL=slugCheck.directive.js.map