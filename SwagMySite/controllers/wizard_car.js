app.controller('WizdardCarController', function($scope, $http, $location,user,vechicleSaver) {

	$scope.goView = function(view){
		$location.path(view);
	}
	$scope.user = user.getName();
	$scope.globalVehicleID = vechicleSaver.getVID();


	// ------ Save type ------ //
	$scope.saveTheVehicleID = function(id){
		vechicleSaver.setVehicleID(id);
		$location.path('/check_marca_car');
	};

	// ------ Marcas ------ //

	$scope.carMarcas = [];
	$scope.getMarcaByID = function(){
		$scope.vehicleID = vechicleSaver.getVID();
		var uri = "http://swagmyapi.azurewebsites.net/api/data/vehiclebrand/type/" + $scope.vehicleID;
		$http.get(uri).then(function(callback){
			$scope.carMarcas = callback.data;
			console.log("Marcas: " , callback.data);
		});
	};

	$scope.marcaInfo = null;
	$scope.getMarcaInfo = function(vehicleBrandId) {
		$scope.marcaInfo = $scope.carMarcas.find(function(item){return item.vehicleBrandId == vehicleBrandId});
		vechicleSaver.setVehicleNameModel($scope.marcaInfo.brandName);
	};

	$scope.saveMarca = function(marcaID){
		vechicleSaver.setVehicleMarca(marcaID);
		$location.path('/check_submarca_car');
	};

	// ------ SubMarca ------ //

	$scope.carSubmarca = [];
	$scope.getSubMarca = function(){
		$scope.marcaID = vechicleSaver.getVMarca();
		var uri = "http://swagmyapi.azurewebsites.net/api/data/vehiclemodel/brandid/" + $scope.marcaID;
		$http.get(uri).then(function(callback){
			$scope.carSubmarca = callback.data;
			console.log("SubMarcas: " , callback.data);
		});
	};

	$scope.SubmarcaInfo = null;
	$scope.getSubMarcaInfo = function(vehicleModelId) {
		$scope.SubmarcaInfo = $scope.carSubmarca.find(function(item){return item.vehicleModelId == vehicleModelId});
		vechicleSaver.setVehicleYear($scope.SubmarcaInfo.vehicleYearModel);
		vechicleSaver.setVehicleNameBrand($scope.SubmarcaInfo.vehicleNameModel);
	};

	$scope.saveSubMarca = function(SubMarcaId){
		vechicleSaver.setVehicleSubMarca(SubMarcaId);
		$location.path('/crear_car');
	};

	// ------ AllOtherFields ------ //







});