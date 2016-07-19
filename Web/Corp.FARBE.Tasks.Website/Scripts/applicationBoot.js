var tasksApp = angular.module('tasksApp', []);

tasksApp.controller('taskController',function($scope,$http,$q){
    
    $scope.loding = false;
    $scope.testText = "ANGULAR JS WORKED FINE...";
    $scope.getText = "ANGULAR JS WORKED FINE..11.";

    $scope.filter = {
        street: "ANGULAR JS WORKED FINE...",
        address: "ANGULAR JS WORKED FINE...",
        city: "ANGULAR JS WORKED FINE...",
        zipCode: "ANGULAR JS WORKED FINE...",
        type: "ANGULAR JS WORKED FINE...",
        take: 2,
        skip: 0
    };


});