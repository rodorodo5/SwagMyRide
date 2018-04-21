<?php 
    include_once '../connection.php';
    require 'master.php';

    $login = new master();

    $data = json_decode(file_get_contents("php://input"));

    $email = $data->email;
    $password = $data->password;

    $email = addslashes($email);

    if(!empty($email) && !empty($password)){
        $login->user_login($email,$password);
    }else{
        echo json_encode("All fields required");
    }

?>