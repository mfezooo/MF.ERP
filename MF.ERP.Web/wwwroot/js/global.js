function copyNameVal() {
   let nameEn = $("#nameEnInput").val();
    if (nameEn == null || nameEn == '') {
        let nameAr = $("#nameInput").val();
        $("#nameEnInput").val(nameAr);         
    }

}

function getEntityById(controllerName, entityId, successCallback, errorCallback) {
    $.ajax({
        url: controllerName + '\\GetById?id=' + entityId,
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            if (typeof successCallback === 'function') {
                successCallback(response);
            }
        },
        error: function (xhr, status, error) {
            if (typeof errorCallback === 'function') {
                errorCallback(xhr, status, error);
            } else {
                console.error('Error fetching entity:', error);
            }
        }
    });
}
function deleteById(controllerName, entityId, successCallback, errorCallback) {
    $.ajax({
        url: controllerName + '\\delete?id=' + entityId,
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            if (typeof successCallback === 'function') {
                successCallback(response);
            }
        },
        error: function (xhr, status, error) {
            if (typeof errorCallback === 'function') {
                errorCallback(xhr, status, error);
            } else {
                console.error('Error fetching entity:', error);
            }
        }
    });
}