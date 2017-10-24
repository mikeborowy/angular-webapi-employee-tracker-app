(function () {
    'use strict';

    angular
        .module('app.common')
        .factory('common', common);

    common.$inject = ['$http'];

    function common($http) {
        var service = {
            // common angular dependencies
            $http: $http,
            // generic
            transform: Transform
        };

        return service;

        ////////////////

        // Transform json result to a given object
        function Transform(jsonResult, constructor, user, propertyName) {

            if (angular.isArray(jsonResult)) {

                var models = [];

                angular.forEach(jsonResult, function (object) {
                    models.push(TransformObject(object, constructor, user, propertyName));
                });

                return models;
            }
            else
            {
                return TransformObject(jsonResult, constructor, user, propertyName);
            }
        }

        /*** Private Methods ***/
        function TransformObject(jsonResult, constructor, user, propertyName) {

            var model = new constructor();
            model.toObject(jsonResult, user, propertyName);

            return model;
        }

    }
})();