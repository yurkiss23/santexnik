$(function(){
    let canvasTrouble=$("#canvasTrouble");
    //let shot=$("#shot");
    canvasTrouble.hide();
    $("#shot").on("click",function(){
        canvasTrouble.show();
    });
})