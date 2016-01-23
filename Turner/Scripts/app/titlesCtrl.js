var app = angular.module('app', ['ngRoute']);

//app.config(function ($routeProvider) {

//    $routeProvider.when('/allmovies', {
//        templateUrl: 'Templates/AllMovies.html',
//        controller: 'titlesController'
    
//    })
//    .otherwise({ redirectTo: '/' });
//});

app.controller('titlesController', ['$scope', '$http', titlesController]);



function titlesController($scope, $http) {

    $scope.resultTitles = [];
    angular.element(document).ready(function () {
        $http.get("/api/Titles").success(function (data) {

            $scope.resultTitles = data;
        })



    });

    $scope.getTitlebyname = function (name) {
        if (name != undefined) {
            $http.get("api/TitlebyName", { params: { "name": name } }).success(function (data) {

                $scope.resultTitles = data;

            });
        }
       
    }

   
}
