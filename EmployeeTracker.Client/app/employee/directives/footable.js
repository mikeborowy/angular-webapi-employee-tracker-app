(function () {
    'use strict';

    angular
        .module('app.common')
        .directive('epFooTable', fooTable);

    fooTable.$inject = ['$timeout'];

    function fooTable($timeout) {

        return {
            restrict: 'A',
            link: Link
        }

        function Link(scope, element, attrs) {

            element.footable(scope.$eval(attrs.footable));
            $timeout(function () {

                element.trigger('footable_redraw');

            }, 100);
        }
    }

})();