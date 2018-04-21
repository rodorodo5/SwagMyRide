<?php
include_once '../connection.php';
// header('Access-Control-Allow-Origin: *');
// header('Content-Type: application/json');

class User {
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }

        public function login($username,$password){
        	$response = [];
        	$sql = "SELECT * FROM users WHERE Username='$username' AND Password='$password'";
			$result = mysqli_query($this->connection, $sql);
			if(mysqli_num_rows($result) > 0) {
				$response['status'] = 'loggedin';
				$response['user'] = $username;
				$response['id'] = md5(uniqid());
				$_SESSION['id'] = $response['id'];
				$_SESSION['user'] = $username;
			} else {
				$response['status'] = 'error';
			}
			echo json_encode($response);
        }//function
   }//class

if(!isset($_POST)) die();
session_start();
$user = new User();
$username = $_POST['username'];
$password = $_POST['password'];
$user-> login($username,$password);


