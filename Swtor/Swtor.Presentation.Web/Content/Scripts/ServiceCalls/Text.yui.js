/// <reference path="../jquery-vsdoc.js" />

function TextSave(textId, content, callback)
{
    var webMethod = '/InternalService.asmx/TextSave';
    var parameters = "{'textId':" + textId + ", 'content':'" + content + "'}";
    $.ajax({
        type: "POST",
        url: webMethod,
        data: parameters,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg)
        {
            callback(msg.d);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown)
        {
            var err = eval("(" + XMLHttpRequest.responseText + ")");
            alert(data);
            callback(null);
        }
    });
}
        
    