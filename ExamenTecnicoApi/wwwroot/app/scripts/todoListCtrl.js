'use strict';
angular.module('examenTecnicoApp')
.controller('todoListCtrl', ['$scope', '$location', 'todoListSvc', function ($scope, $location, todoListSvc) {
    $scope.error = "";
    $scope.loadingMessage = "Loading...";
    $scope.todoList = null;
    $scope.editingInProgress = false;
    $scope.newToDoName = "";
    $scope.provinciasLista = "";


    $scope.editInProgressTodo = {
        nombre: "",
        apellido: "",
        roles:[],
        id: 0
    };

    

    $scope.update = function (todo) {
        $scope.editInProgressTodo.isComplete = todo.isComplete;
        todoListSvc.putItem($scope.editInProgressTodo).success(function (results) {
            $scope.loadingMsg = "";
        }).error(function (err) {
            $scope.error = err;
            $scope.loadingMessage = "";
        })
    };
    $scope.add = function () {
        if ($scope.editingInProgress) {
            $scope.editingInProgress = false;
        }
        todoListSvc.postItem({
            'Name': $scope.newToDoName,
            'IsComplete': false
        }).success(function (results) {
            $scope.loadingMsg = "";
            $scope.newToDoName = "";
        }).error(function (err) {
            $scope.error = err;
            $scope.loadingMsg = "";
        })
    };

    $scope.login = function () {
        if ($scope.editingInProgress) {
            $scope.editingInProgress = false;
        }
        todoListSvc.login({
            'Nickname': $scope.nickname,
            'Pwd': $scope.pwd
        }).success(function (results) {
            $scope.loadingMsg = "";
            $scope.newToDoName = "";
            $scope.error = "";
        }).error(function (err) {
            $scope.error = err;
            $scope.loadingMsg = "";
        })
    };

    $scope.buscar = function () {
        todoListSvc.buscar($scope.provinciaNombre).success(function (results) {
            $scope.provinciasLista = results;
            $scope.loadingMsg = "";
            $scope.newToDoName = "";
            $scope.error = "";
        }).error(function (err) {
            $scope.error = err;
            $scope.loadingMsg = "";
        })
    };

}]);
