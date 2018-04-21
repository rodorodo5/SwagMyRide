app.controller('panelController', function($scope, user, $http,$location,dataFactory,$routeParams,$window) {
	//Panel controller, requests and front-end logic
	$scope.data = [];
	$scope.libraryTemp = {};
	$scope.totalItemsTemp = {};
	$scope.posts = [];
	$scope.totalItems = 0;
	$scope.urID = $routeParams.id;
  
    $scope.user = user.getName();
    $scope.goView = function(view){
        $location.path(view);
    };
    var URL = "http://localhost/myride"


    $scope.goModify = function(id){
        var landingUrl = URL + "#!/modify/"+id;
        $window.location.href = landingUrl;
    }



    $scope.showVehicletoModify = function(id) {
    	console.log(id)
    	//request de info de ese vehiculo para modificarlo despues
       	$scope.vID = id; 
    };


     $scope.showVehicletoModify($scope.urID);
    
 




	
});