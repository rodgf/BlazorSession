
export function sendSessionStorage() {
  var sessionStorage = window['sessionStorage'];
  var sessionStorageObj = JSON.stringify(sessionStorage);

  $.ajax({
    url: "/Session/SetValues",
    type: "POST",
    data: { sessionStorageObj: sessionStorageObj },
    success: function (result) {
      console.log(result);
    },
    error: function (result) {
      console.log(result);
    }
  });
}

//
export function exibeMsg(msg) {
  alert(msg);
}
