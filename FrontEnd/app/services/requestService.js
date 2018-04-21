app.factory('dataFactory', function($http) {
  var myService = {
    httpRequest: function(url,method,params,dataPost,upload) {
      var passParameters = {};
      passParameters.url = url;

      if (typeof method == 'undefined'){
        passParameters.method = 'GET';
      }else{
        passParameters.method = method;
      }

      if (typeof params != 'undefined'){
        passParameters.params = params;
      }

      if (typeof dataPost != 'undefined'){
        passParameters.data = dataPost;
      }

      if (typeof upload != 'undefined'){
         passParameters.upload = upload;
      }
      var promise = $http(passParameters).then(function (response) {
        if(typeof response.data == 'string' && response.data != 1){
          if(response.data.substr('login')){
              
              return;
          }
          $.gritter.add({
            title: 'Application',
          
          });
          return false;
        }  text: response.data
        if(response.data.jsMessage){
          // $.gritter.add({
          //   title: response.data.jsTitle,
          //   text: response.data.jsMessage
          // });
        }
        return response.data;
      },function(){

        // $.gritter.add({
        //   title: 'Application',
        //   text: 'Error ocurrio'
        // });
      });
      return promise;
    }
  };
  return myService;
});


app.factory('Http', function($http){
  return {
    post: function(form_data){
      var request = $http({
        method:'post',
        url: URL,
        data:form_data
      });
      return request;
    },
    send: function(request,callback){
      request.then(function(response){
        callback(response);
      }).catch(function(msg){
        alert(msg.data);
      });
    }
  }

});

// app.factory('User',  function(){
//     var obj={
//       isLogged: false,
//       user_id : '',
//       username:'',
//     }
//     return obj;
// });


// app.factory('checkLogin',  function(Http,User){
//   return {
//     check : function(callback){
//       var data = {
//         token : localStorage['token'];
//       }
//       var request = Http.post(data);
//       Http.send(request,function(response){
//         console.log(response);
//         callback(User.isLogged);
//       })
//     }

//   }
// });







