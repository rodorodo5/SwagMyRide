app.service('user', function() {
	var email;
	var loggedin = false;
	var id;

	this.getName = function() {
		return email;
	};

	this.setID = function(userID) {
		id = userID;
	};
	this.getID = function() {
		return id;
	};

	this.isUserLoggedIn = function() {
		if(!!localStorage.getItem('login')) {
			loggedin = true;
			var data = JSON.parse(localStorage.getItem('login'));
			email = data.email;
			id = data.id;
		}
		return loggedin;
	};

	this.saveData = function(data) {
		email = data.user;
		id = data.id;
		loggedin = true;
		localStorage.setItem('login', JSON.stringify({
			email: email,
			id: id
		}));
	};

	this.clearData = function() {
		localStorage.removeItem('login');
		email = "";
		id = "";
		loggedin = false;
	}
})



