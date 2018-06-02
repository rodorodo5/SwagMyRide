app.controller('createController', function($scope, $http, $location, user, $sce,vechicleSaver) {

	$scope.user = user.getName();
	$scope.globalVehicleID = vechicleSaver.getVID();
	$scope.goView = function(view){
		$location.path(view);
	}

	// ------------------- START Brakes --------------------

	$scope.fillBreaks = [];
	$scope.breaksClicked = false;


	$scope.fill_breaks = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.breaksClicked) {
			$scope.breaksClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/break/component/'+ vehicleModelId).then(function(callback){
				console.log("Breaks: ", callback);
				$scope.fillBreaks = callback.data;
			});
		}
	};

	 $scope.brakeInfo = null;
	  $scope.getBrakeInfo = function(brakeId) {
	    $scope.brakeInfo = $scope.fillBreaks.find(function(item){return item.brakeId == brakeId});
	    //vechicleSaver.setVehicleCombustible($scope.motorInfo.combustibleId);
	  }


	// ------------------- START Motor --------------------

	$scope.fillMotor = [];
	$scope.motorClicked = false;

	$scope.fill_motor = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.motorClicked) {
			$scope.motorClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/motor/component/'+ vehicleModelId).then(function(callback){
				console.log("Motor: " , callback);
				$scope.fillMotor = callback.data;
			});
		}
	};

	 $scope.motorInfo = null;
	  $scope.getMotorInfo = function(motorId) {
	    $scope.motorInfo = $scope.fillMotor.find(function(item){return item.motorId == motorId});
	    vechicleSaver.setVehicleCombustible($scope.motorInfo.combustibleId);
	}


	// ------------------- START Bodyw --------------------

	$scope.fillBodyw = [];
	$scope.bodywClicked = false;

	$scope.fill_bodywork = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.bodywClicked) {
			$scope.bodywClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/bodywork/component/'+ vehicleModelId).then(function(callback){
				console.log("BodyWork: " ,callback);
				$scope.fillBodyw = callback.data;
			});
		}
	};

	 $scope.bodyWinfo = null;
	  $scope.getBodywInfo = function(bodyWorkId) {
	    $scope.bodyWinfo = $scope.fillBodyw.find(function(item){return item.bodyWorkId == bodyWorkId});
	}


	// ------------------- START Electric --------------------

	$scope.fillElectric = [];
	$scope.ElectricClicked = false;

	$scope.fill_electric = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.ElectricClicked) {
			$scope.ElectricClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/electricsystem/component/'+ vehicleModelId).then(function(callback){
				console.log("Electric Sys: " ,callback);
				$scope.fillElectric = callback.data;
			});
		}
	};

	 $scope.ElectricInfo = null;
	  $scope.getElectricInfo = function(electicSystemId) {
	    $scope.ElectricInfo = $scope.fillElectric.find(function(item){return item.electicSystemId == electicSystemId});
	}

	// ------------------- START Suspension --------------------

	$scope.fillSuspension = [];
	$scope.SuspensionClicked = false;

	$scope.fill_suspension = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.SuspensionClicked) {
			$scope.SuspensionClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/suspension/component/'+ vehicleModelId).then(function(callback){
				console.log("Suspension: " ,callback);
				$scope.fillSuspension = callback.data;
			});
		}
	};

	 $scope.SuspensionInfo = null;
	  $scope.getSuspensionInfo = function(suspensionId) {
	    $scope.SuspensionInfo = $scope.fillSuspension.find(function(item){return item.suspensionId == suspensionId});
	}

	// ------------------- START llantas --------------------

	$scope.fillLlantas = [];
	$scope.LlantasClicked = false;

	$scope.fill_llantas = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.LlantasClicked) {
			$scope.LlantasClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/wheel/component/'+ vehicleModelId).then(function(callback){
				console.log("Llantas: " ,callback);
				$scope.fillLlantas = callback.data;
			});
		}
	};

	 $scope.LlantasInfo = null;
	  $scope.getLlantasInfo = function(wheelId) {
	    $scope.LlantasInfo = $scope.fillLlantas.find(function(item){return item.wheelId == wheelId});
	}

	// ------------------- START Rines --------------------

	$scope.fillRines = [];
	$scope.RinesClicked = false;

	$scope.fill_rines = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.RinesClicked) {
			$scope.RinesClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/tires/component/'+ vehicleModelId).then(function(callback){
				console.log("Rines: " ,callback);
				$scope.fillRines = callback.data;
			});
		}
	};

	 $scope.RinesInfo = null;
	  $scope.getRinesInfo = function(tiresId) {
	    $scope.RinesInfo = $scope.fillRines.find(function(item){return item.tiresId == tiresId});
	}

	// ------------------- START turbinas --------------------

	$scope.fillTurbinas = [];
	$scope.turbinaClicked = false;


	$scope.fill_turbinas = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.turbinaClicked) {
			$scope.turbinaClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/turbines/component/'+ vehicleModelId).then(function(callback){
				console.log("Turbinas: ", callback);
				$scope.fillTurbinas = callback.data;
			});
		}
	};

	 $scope.TurbinaInfo = null;
	  $scope.getTurbinaInfo = function(turbinesId) {
	    $scope.TurbinaInfo = $scope.fillTurbinas.find(function(item){return item.turbinesId == turbinesId});
	  }


	// ------------------- START blades --------------------

	$scope.fillBlades = [];
	$scope.bladesClked = false;


	$scope.fill_blades = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.bladesClked) {
			$scope.bladesClked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/boatblades/component/'+ vehicleModelId).then(function(callback){
				console.log("Blades: ", callback);
				$scope.fillBlades = callback.data;
			});
		}
	};

	 $scope.bladesInfo = null;
	  $scope.getbladesInfo = function(boatBladesId) {
	    $scope.bladesInfo = $scope.fillBlades.find(function(item){return item.boatBladesId == boatBladesId});
	  }


	// ------------------- START InsertCar --------------------

	$scope.insertCar = function(){

		var VehicleTypeId = vechicleSaver.getVID();
		var BrandId = vechicleSaver.getVMarca();
		var ModelId = vechicleSaver.getVSubMarca();
		var combustibleId = vechicleSaver.getVCombustible();
		var vehicleYear = vechicleSaver.getVYear();
		var UserId = user.getID();
		var ModelName = vechicleSaver.getVNameModel();
		var BrandName = vechicleSaver.getVNamebrand();


		var data = {
			TiresId : $scope.car.rines,
			BrakeId: $scope.car.brake,
			SuspensionId: $scope.car.suspension,
			MotorId: $scope.car.motor,
			ProvideUser: parseInt(UserId),
			ProvideVehicleType: VehicleTypeId,
			Color: $scope.car.color,
			ProvideBodyWork: $scope.car.bodywork,
			ProvideElectrySystem: $scope.car.electric,
			ProvideCombustibleId: combustibleId,
			ProvideModelId : ModelId,
			ProvideVehicleYear : vehicleYear,
			ProvideVehicleBrandId: BrandId,
			WheelId: $scope.car.llantas,
			ProvideBrandName: BrandName,
			ProvideModelName: ModelName
		}

		console.log(data)
		
		$http.post('http://swagmyapi.azurewebsites.net/api/data/vehicle', data ).then(function(callback){
				console.log("Insert car: " ,callback);
				if (callback.data === 'Success') {
					alert("Vehiculo insertado")
					$location.path('/edit');

				}
				else {
					alert("Asegurate de seleccionar todos los campos.")
				}

		});
	}

	// ------------------- START InsertPlane --------------------

	$scope.insertPlane = function(){

		var VehicleTypeId = vechicleSaver.getVID();
		var BrandId = vechicleSaver.getVMarca();
		var ModelId = vechicleSaver.getVSubMarca();
		var combustibleId = vechicleSaver.getVCombustible();
		var vehicleYear = vechicleSaver.getVYear();
		var UserId = user.getID();
		var ModelName = vechicleSaver.getVNameModel();
		var BrandName = vechicleSaver.getVNamebrand();

		var data = {
			BrakeId: $scope.car.brake,
			SuspensionId: $scope.car.suspension,
			MotorId: $scope.car.motor,
			ProvideUser: parseInt(UserId),
			ProvideVehicleType: VehicleTypeId,
			Color: $scope.car.color,
			ProvideBodyWork: $scope.car.bodywork,
			ProvideElectrySystem: $scope.car.electric,
			ProvideCombustibleId: combustibleId,
			ProvideModelId : ModelId,
			ProvideVehicleYear : vehicleYear,
			ProvideVehicleBrandId: BrandId,
			WheelId: $scope.car.llantas,
			Turbines: $scope.car.turbinas,
			TurbinesCount: $scope.car.numturbinas,
			ProvideBrandName: BrandName,
			ProvideModelName: ModelName
		}

		console.log(data)
		
		$http.post('http://swagmyapi.azurewebsites.net/api/data/vehicle', data ).then(function(callback){
				console.log("Inser plane: " ,callback);
				if (callback.data === 'Success') {
					alert("Vehiculo insertado")
					$location.path('/edit');
				}
				else {
					alert("Asegurate de seleccionar todos los campos.")
				}

		});
	}

	$scope.insertBoat = function(){

		var VehicleTypeId = vechicleSaver.getVID();
		var BrandId = vechicleSaver.getVMarca(); //id
		var ModelId = vechicleSaver.getVSubMarca(); //id
		var combustibleId = vechicleSaver.getVCombustible();
		var vehicleYear = vechicleSaver.getVYear();
		var UserId = user.getID();
		var ModelName = vechicleSaver.getVNameModel();
		var BrandName = vechicleSaver.getVNamebrand();

		var data = {
			MotorId: $scope.car.motor,
			ProvideUser: parseInt(UserId),
			ProvideVehicleType: VehicleTypeId,
			Color: $scope.car.color,
			ProvideBodyWork: $scope.car.bodywork,
			ProvideElectrySystem: $scope.car.electric,
			ProvideCombustibleId: combustibleId,
			ProvideModelId : ModelId,
			ProvideVehicleYear : vehicleYear,
			ProvideVehicleBrandId: BrandId,
			BoatBladesId: $scope.car.blades,
			BoatBladesCount: $scope.car.numblades,
			ProvideBrandName: BrandName,
			ProvideModelName: ModelName
		}

		console.log(data)
		
		$http.post('http://swagmyapi.azurewebsites.net/api/data/vehicle', data ).then(function(callback){
				console.log("Inser boat: " ,callback);
				if (callback.data === 'Success') {
					alert("Vehiculo insertado")
					$location.path('/edit');
				}
				else {
					alert("Asegurate de seleccionar todos los campos.")
				}

		});
	}

});
