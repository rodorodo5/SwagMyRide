<?php

    include_once '../connection.php';

    class User {
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function edit_thing($id)
        {
            $sql = "SELECT * FROM posts WHERE id = '$id'";  
            $result = mysqli_query($this->connection, $sql);
            $data = $result->fetch_assoc();
            echo json_encode($data);
        }
    }
    $user = new User();
    if(isset($_GET['id'])) {
        $id  = $_GET["id"];
        if(!empty($id)){
            $user-> edit_thing($id);
            
        }else{
            echo json_encode("Not a vaild id");
        }
    }
        
?>