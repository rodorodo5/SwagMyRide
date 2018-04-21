app.controller('createVehicleController', function($scope, user, $http,$location,dataFactory) {
	//Panel controller, requests and front-end logic
	$scope.data = [];
	$scope.libraryTemp = {};
	$scope.totalItemsTemp = {};
	$scope.posts = [];
	$scope.totalItems = 0;
  
    $scope.user = user.getName();
    $scope.goView = function(view){
        $location.path(view);
    };

    //request de vehiculos por usuario
    

});