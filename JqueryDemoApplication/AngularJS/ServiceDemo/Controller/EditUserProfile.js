
var demoApp = angular.module('demoApp', []);

demoApp.controller('EditUserProfile', function ($scope, gravatarUrlBuilder) {
    $scope.gravatar = function (Email) {
        return gravatarUrlBuilder.buildGravatarUrl(Email);
    };

});