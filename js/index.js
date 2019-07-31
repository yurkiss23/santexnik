$(function(){
    let canvasTrouble=$("#canvasTrouble");
    let context=canvasTrouble.get(0).getContext("2d");
    //let shot=$("#shot");
    canvasTrouble.hide();
    $("#signShot").hide();
    $("#btnShot").on("click",function(){
        context.canvas.height=400;
        $("#btnShot").hide();
        $("#sign").hide();
        canvasTrouble.show();
        $("#signShot").show();
    });
})