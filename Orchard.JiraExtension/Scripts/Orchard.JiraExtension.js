var OJE = {};
OJE.Issues = new Array();
OJE.IssuePattern = "";
OJE.ParseText = function(textAreaToken) {
    var textToParse = $(textAreaToken).text();
    var issueRegExp = new RegExp("https://issues.belitsoft.com/browse/[A-Z]{5}-[0-9]{2}", "g");
    if (textToParse.match(issueRegExp).length > 0) {
        alert(textToParse.match(issueRegExp)[0]);
    }
}