var tasksApp = angular.module('tasksApp', []);
var apiUrl = 'http://localhost:60189/';

tasksApp.controller('taskController',function($scope,$http,$q){
    
    $scope.loding = false;
    $scope.totalRows = 0;
    $scope.musteriler ;


    $scope.load = function GetMusteriler() {
        
        $scope.loading = true;

        var request = {
            method: 'POST',
            url: apiUrl + 'api/Musteriler',
            headers: {
                'Content-Type': 'application/json',
                'Content-Length': '500'
            }
        }
        $http(request)
        .success(function (result) {
            $scope.musteriler = result.Items;
            $scope.totalRows = result.TotalRecords;
            $scope.loading = false;
        }).error(function (data, status, headers, config) {
            $scope.musteriler = [{ Musteri_Name: status }, { Musteri_Name: "test2" }, { Musteri_Name: "test3" }];
            $scope.loading = false;
        });
        
    };


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