<?php 
    include_once '../connection.php';
    require 'master.php';
    $signup = new master();
    $data = json_decode(file_get_contents("php://input"));
    $email = $data->email;
    $password = $data->password;
    $nombre = $data->nombre;
    $apellido = $data->apellido;
    $isAdmin = $data->isAdmin;
    $signup-> signup($email,$password,$nombre,$apellido,$isAdmin); 
?>