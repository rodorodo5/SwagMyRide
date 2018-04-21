<?php
	
	include_once '../connection.php';

    class User {
        
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function file_change($error,$filename,$tmp_name)
        {
            if ( 0 < $error ) {
		        echo 'Error: ' . $error . '<br>';
		    }
		    else {
		        move_uploaded_file($tmp_name, '../uploads/' . $filename);
		    }
        }
    }

    $user = new User();
    
    $error = $_FILES['file']['error'];
    $tmp_name = $_FILES['file']['tmp_name'];
	$filename = $_FILES['file']['name'];
    $user-> file_change($error,$filename,$tmp_name)



   

?>