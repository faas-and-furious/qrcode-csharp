# FaaS QR Code using C#

Inspired by John McCabe's [qrcode](https://github.com/faas-and-furious/qrcode) function in Go, I made one in C#!

## Deploying the function

Be sure to follow the instructions on the [FaaS repo](https://github.com/alexellis/faas) to deploy the Faas stack.

**Get the CLI**

You can install the [faas-cli](https://github.com/alexellis/faas-cli/) via `brew install faas-cli` or `curl -sSL https://get.openfaas.com | sudo sh`.

**Build and deploy**

Build and deploy your stack using the following commands:

```
$ faas-cli -action build -f ./test.yml
$ faas-cli -action deploy -f ./test.yml
```

**Test**

Using `curl`, you can send a URL (or any data) to the function to generate a QR code:

```
$ curl localhost:8080/function/qrcode -d 'http://get-faas.com' > qrcode.png
```

![](images/qrcode.png)

Voila! You have a QR code! You can check it via Android using [this app](https://play.google.com/store/apps/details?id=com.google.zxing.client.android).
