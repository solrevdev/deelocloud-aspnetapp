# deelocloud-aspnetapp

A sample .NET Core Razor Pages app with root Dockerfile to test out [Deelo Cloud](https://www.deelo.cloud/).

Deployed to [https://deelocloud-aspnetapp.deelo.cloud/](https://deelocloud-aspnetapp.deelo.cloud/) 🚀

## .NET Core Razor Pages

The app was created using the `dotnet new webapp` template and is the default output for a .NET Core Razor Pages app.

## Docker

I am using the alpine image and using trimming and various other dotnet publish techniques to keep the image small and fast however the tradeoff is that the docker build command does take longer.

### Build

```bash
docker build --pull --rm -f "Dockerfile" -t deelocloudaspnetapp:latest "."
```

### Run

```bash
docker run --rm -it  -p 80:80/tcp deelocloudaspnetapp:latest
```

### Test

```bash
curl http://localhost:80
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update any tests as appropriate.

## License
[MIT](LICENSE)
