var tasksApp = angular.module('tasksApp', []);

tasksApp.controller('taskController',function($scope,$http,$q){
    
    $scope.loding = false;
    $scope.testText = "ANGULAR JS WORKED FINE...";
    $scope.getText = "ANGULAR JS WORKED FINE..11.";

    $scope.filters =[{
        street: "ANGULAR JS ...",
        address: "ANGULAR JS ...",
        city: "ANGULAR JS ...",
        zipCode: "ANGULAR JS ...",
        type: "ANGULAR JS ...",
        take: 2,
        skip: 0
    },
    {
        street: "ANGULAR JS ..2222.",
        address: "ANGULAR JS..2222.",
        city: "ANGULAR JS .2222..",
        zipCode: "ANGULAR JS .22222..",
        type: "ANGULAR JS .22222..",
        take: 22,
        skip: 0
    }];


});