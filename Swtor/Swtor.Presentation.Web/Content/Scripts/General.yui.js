/// <reference path="jquery-vsdoc.js" />

var height = $(window).height() - ($("header").height() + $("footer").height()) + 20;
$("#content").height(height);
$("#contentBackground").animate({ height: height }, 1000, 'swing', function () { $("nav").fadeIn("slow"); });

$(window).resize(function ()
{
    var height = $(window).height() - ($("header").height() + $("footer").height()) + 20;
    $("#content").height(height);
    $("#contentBackground").height(height);
});

var $container = $('#container');

$container.imagesLoaded(
    function(){
        $container.masonry({
        itemSelector : '.item',
        columnWidth : 450,
        isResizable: true,
        isFitWidth: true
    });
});

$('#background').backstretcher(
{
    bgs: '/Content/Images/hope-001.jpg'
});

$('.editable').editable(function (value, settings)
{
    var textId = $(this).attr("data-textId");
    TextSave(textId, value);
    UpdateBricks();
    return (value);
}, {
    type: 'wysiwyg',
    onblur: 'ignore',
    submit: 'Save',
    cancel: 'Cancel',
    onreset: function ()
    {
        UpdateBricks();
    }
}).click(function ()
{
    UpdateBricks();
});

 function UpdateBricks() 
 {
     var $container = $('#container');

    $container.imagesLoaded(
        function(){
            $container.masonry({
            itemSelector : '.item',
            columnWidth : 450,
            isResizable: true,
            isFitWidth: true
        });
    });
 }