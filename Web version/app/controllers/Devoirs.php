<?php

class Devoirs extends Controller {
    public function __construct(){
      if(!isLoggedIn()){
        redirect('users/login');
      }
      if( ($_SESSION['user_role_id'])!=2)
      {
        redirect('pages');
      }
    
             //import du models
     $this->devoirModel = $this->model('Devoir');

    }

    //affichage
    public function index(){
        //trouver tous les devoirs
        $devoirs = $this->devoirModel->getDevoirs();
        
            $data = [
                'devoirs' => $devoirs
            ];
        
            $this->view('devoirs/index',$data);
        
        }
        
            //ajout
          public function add(){
            if($_SERVER['REQUEST_METHOD'] == 'POST'){
              $data = [
                'devoir'   =>trim($_POST["devoir"]) 
              ];
              if($this->devoirModel->addDevoir($data)){
                redirect('devoirs');
              } else 
                die("Erreur d'ajout du devoir !!! ");
            }
            else
              $this->view('devoirs/add');
      
          }

          //modification
          public function edit($id){
            if($_SERVER['REQUEST_METHOD'] == 'POST'){
           
              $data = [
                'id' => $id,
                'devoir' => trim($_POST["devoir"])
              ];
              if($this->devoirModel->updateDevoir($data)){
                redirect('devoirs');
              } else 
                die("Erreur de modification du devoir !!!");
            } else {
              // Obtenir le devoir existante à partir du model
              $devoir = $this->devoirModel->getDevoirById($id);
              $data = [
                'id' => $id,
                'devoir' => $devoir->type_devoir
              ];
        
              $this->view('devoirs/edit', $data);
            }
          }
      

          //suppression
          public function delete($id){
            // Obtenir le devoir existante à partir du model
            $devoir = $this->devoirModel->getDevoirById($id);
      
            if($this->devoirModel->deleteDevoir($id)){
              redirect('devoirs');
            } else {
              die("Erreur de suppression du devoir !!!");
            }
          }
      

    
      }











