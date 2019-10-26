function codeBehindCall(method, url_, data_, container, dataType_) {    
    $.ajax({
        type: method,
        url: url_,
        data: data_,
        success: function (result, status, xhr) {
            $('#' + container).html(result);
        },
        error: function (xhr) {
            $('#' + container).html('Ocorreu um erro ao realizar a requisição');            
        },
        dataType: dataType_
    });
}

