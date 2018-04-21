<?php
    include_once '../connection.php';
    class User {
        
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function delete_id($id)
        {
            $sql = "DELETE FROM posts WHERE id = '$id'";
            $result = mysqli_query($this->connection, $sql);
            echo json_encode([$id]);
        }
    }
    $user = new User();
    $id  = $_GET["id"];
    if(!empty($id)){
        $user-> delete_id($id);
    }else{
        echo json_encode("All fields required");
    }
?>