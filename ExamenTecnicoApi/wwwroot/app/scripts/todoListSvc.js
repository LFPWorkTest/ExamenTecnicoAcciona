'use strict';
angular.module('examenTecnicoApp')
.factory('todoListSvc', ['$http', function ($http) {

    $http.defaults.useXDomain = true;
    delete $http.defaults.headers.common['X-Requested-With']; 

    return {
        login: function (usuario) {
            return $http.post('/api/Usuario/Login', usuario);
        },
        buscar: function (provnciaNombre) {
            return $http.get('/api/Provincias/Buscar/' + provnciaNombre);
        }
    };
}]);