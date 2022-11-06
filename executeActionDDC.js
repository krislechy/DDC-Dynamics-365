const Messages = {
    BTN_DO_DOWNLOAD_DOCUMENTS: 'Выгрузить документы',
    WRITE_CONTROL_DATE: 'Для выгрузки документов укажите контрольную дату',
    BTN_DOWNLOAD: 'Выгрузить',
    BTN_CONFIRM: 'Хорошо',
    STATUS_SUCCESS: 'Успешное завершение',
    STATUS_FAIL: 'Возникла ошибка внутри плагина',
    STATUS_CONTINUE: 'Задача продолжает свою работу в фоне...',
}
async function OnClickStartDDC() {
    InsertFavicon("..//WebResources/ylv_download.svg");
    InsertDate();
    runAction("ylv_DDC", Messages.DO_DOWNLOAD_DOCUMENTS,
        Messages.WRITE_CONTROL_DATE + ":");
}
function runAction(operationName, title, text) {
    Xrm.Navigation.openConfirmDialog({ text: text, title: title, confirmButtonLabel: Messages.BTN_DOWNLOAD }, { height: 200, width: 450 }).then(
        async function (success) {
            if (success.confirmed) {
                Xrm.Utility.showProgressIndicator();
                let geDate = window.parent.document.getElementById("geDate");
                let dt = new Date(geDate.value);
                let dtstr = `${dt.getMonth() + 1}.${dt.getDate()}.${dt.getFullYear()}`;
                await flower.StartAction(operationName, dtstr);
                Xrm.Utility.closeProgressIndicator();
            }
        });
}

function ShowAlertDialog(title, text, IsContinious) {
    if (!IsContinious)
        InsertFavicon("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAABmJLR0QA/wD/AP+gvaeTAAAFP0lEQVRoge2ZW0wUVxjH/2d2Fq1VYmWb1CKhihTtW4XW9MEHrA+14i0ES0tvpgo1StqHqhS8bNOmadKkSaNY6YPGCkFAjZTW9KEhPhuMb1KJTahcjFzWB+3e2P3+fZhdQPYys+ywNpHvYSezM/N9v//5vnNmzjnAvM3b023KFi/tFY58LHkdlFIoVUzhGhDLCS4GCRKPQA4DuE3yBhS7h+4UXofbLemGTktAwZXdeeEJbT/A90nmggBJgACNE5CA8RO9FvkPHCRUsxZE49DelsGMCljdvvv5kKa+AdXHALMmoa3DT14jGYTCGS2ojg7XtI7NuYBVlz55T4gTIJYZIGnBI3IDSDUO4YH71W0X5kRAcVO10+OSUyT3YBLELvjIEQSomka4tBY1P0/YJuDFrupFCwPhiwJsnlv46DPqqlP5K4ZrurxmbJrZDcVN1c7MwgOAvB0UZyfaK7LSFuBxyanMwk/G2JQzGvrRjC9pCa26vLdKRJqfAPy0o1R6ajvbUhaQe/nDHJ3Ov5TA9cTgjRPPRECKHn7RFXeITVhCTtG//R/Ag8Qy3al9lVIGVl/asyIk/Bvpv6TM4UlQjC+KyOPxYgQBFj74rOuupQyEhAcyAi8C3S8oz3sD2aEsIMxEMbKE3BePNVaA260RrMoEvMMvOLPlME5vPYg/qr6HSz0LhCVuDAg+QHuFw1RA/it314NcMfctT5zf1oC3CtcDAApz8tBafgziDyWKkZs96Cs2zwClNBPwv2yrx6aCkpjwyWIokY0zb9djPagSS/BCQAgqhclRxAK8wy84U1YXA983NoDK9uNQC/SEDSSkeQZIvmwKHyKyQ05sX/4adL+AYbHc8tPLJmq9I/3Y0nIQo/wXVIgLH/FTZJ4BYyaVFP45WYCO7cex1pWPiv6b+Ojqd5jIimRjFi2/o/VLjNObHN6gWG6egalpYNx6FH8QLWUNWOvKBwCUvvQqzm4+BIefxggyFy0/ld0lpgIsddgZ9ubKYpzbchiOgBhjuYUO2zvSj22tddZafgZT8gwYE/CE8NpCHe/++jV6x/6JEdFcVg89QCDMaWVzOL2yeaxf4aGpAJD3EsGDBBXwQPOj/PKxGBGlK9fh/NZ6OIOAwy84W1YXUzZ9YwPY2nIolbKZ1q8MtuQCwD7TcV4BHuVH+aVYERtXrsO5sjq7an7moHDbVACJHkuOFTCuvNjZcRS3Rvsf87GpoMTGspkaFBTRYyoAit2WHSsFTwIRM+FnXzZTIxrD0m0qYOhO4XWAA5YdK4UHyoud7Q24NRIrwjZ44V2vbLhhngG3WwjVYtUxYHRsD3zY0Vb/mAjb4EkosCXeUmTc+YAWRCPJoCX4aJCoiAv1uHmvDzfv9aXbYaeOYICKjfFYE86JXzhb+ROEn1qCjx5hvI2jn8RqgW4HPAB10nfkz9q4jZ1IgB4ON5AYSwmexveQWqhDPeO0B54Y10OhhHPihAIG93R4IKhNCT4CY7CZvEuswQPCfQ/d1xIu+iZd2Lpf3XYBVE1PDl4afce7O5Ixmq7MjSzlflJdyTg88buP/NyMz1QAdnWEs5S/iuTVzMHzN58s2gX3tVD6AgAM13R5xzTXDpKnM1I2IjvhNl+ZBmaxwbHsxPZ3QJwk4LIXnqMQ7Der+ZlmKQPTzVPb2TahaWtAnAIQsAE+AKiTzrBzTarwQJqbfDk/lOWGNByAoApgXorwA4pspmKj70j30GwZ7Nlmdbu17OyeEiWyUchiEEUAc0ksjsA/AjFIsk8RPQxLt1c23LBjm3Xe5u1pt/8AL1oe32v4mI4AAAAASUVORK5CYII=");
    else
        InsertFavicon("data:image/png;base64,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");
    Xrm.Navigation.openAlertDialog({ confirmButtonLabel: Messages.BTN_CONFIRM, text: text, title: title }, { height: 300, width: 450 });
}
function getCRMElement(probablyId) {
    return window.parent.document.querySelector("div[id^='" + probablyId + "']");
}
function InsertDate() {
    var checkExist = setInterval(function () {
        if (getCRMElement("dialogTextContainer") != null) {
            clearInterval(checkExist);

            let div = document.createElement("div");
            div.style = "text-align:center;margin-top:20px";

            let input = document.createElement("input");
            input.id = "geDate";
            input.type = "date";
            input.style = "width:50%";

            div.appendChild(input);

            let dialogDiv = getCRMElement("dialogTextContainer");
            dialogDiv.appendChild(div);
        }
    }, 100);
}
function InsertFavicon(src) {
    var checkExist = setInterval(function () {
        if (getCRMElement("dialogTitleView") != null) {
            clearInterval(checkExist);

            var div = getCRMElement("dialogTitleView");

            var img = window.parent.document.createElement("img");
            img.src = src;
            img.width = 32;
            img.style.marginRight = "10px";

            div.insertBefore(img, div.firstChild);
            div.children[1].style.display = "flex";
            div.children[1].style.alignItems = "center";
        }
    }, 100);
}

function ShowErrorDialog(text) {
    Xrm.Navigation.openErrorDialog({ message: text });
}

flower = function () {
    async function startAction(operationName, ge) {
        var req = getRequest(operationName, ge);
        try {
            var result = await Xrm.WebApi.online.execute(req);
            var json = await result.json();
            callBackAction(json);
        }
        catch (ex) {
            ShowErrorDialog(`Ошибка: ${ex.message}`);
        }
    }

    function callBackAction(data) {
        if (data.IsSuccess == true)
            ShowAlertDialog(Messages.STATUS_SUCCESS, `${data.Message}`, false);
        else if (data.IsSuccess == false)
            ShowErrorDialog(`${Messages.STATUS_FAIL}: ${data.Message}`);
        else if (data.IsSuccess == null)
            ShowAlertDialog(Messages.STATUS_CONTINUE, `${data.Message}`, true);
    }

    function getRequest(operationName, ge) {
        var req = {};
        req.ge = ge;
        req.getMetadata = function () {
            return {
                boundParameter: null,
                parameterTypes: {
                    "ge": {
                        "typeName": "Edm.String",
                        "structuralProperty": 1
                    },
                },
                operationType: 0,
                operationName: operationName
            };
        };

        return req;
    }

    return { StartAction: startAction };
}();