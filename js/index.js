$(function(){
    let canvasTrouble=$("#canvasTrouble");
    let context=canvasTrouble.get(0).getContext("2d");
    canvasTrouble.hide();
    $("#btnShot").on("click",function(){
        context.canvas.height=400;
        $("#btnShot").hide();
        $("#sign").hide();
        canvasTrouble.show();
        let shot=document.createElement("button");
        shot.className="btn btn-lg btn-outline-success btn-block";
        shot.innerText="Натисніть";
        quickCall.appendChild(shot);
    });
})