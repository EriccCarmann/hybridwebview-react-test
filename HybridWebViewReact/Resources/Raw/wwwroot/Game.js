function SendMessageToCSharp() {
    var message = document.getElementById("message").value;
    HybridWebView.SendRawMessageToDotNet(message);
}