# Go_Simple

This is an example of submitting a simple prompt for generation in Go using
the [Go SDK for Google Generative AI](https://github.com/google/generative-ai-go) dependency.

Install the dependencies with `go get`:

```
$ go get github.com/google/generative-ai-go/genai
$ go get google.golang.org/api/option
```

Before trying to run it, make sure that you have set the `GEMINI_API_KEY` set to
a valid Gemini API Key. Then you can run it with the `go` command line:

```
$ go run .
```

Or you can build it to a binary with:

```
$ go build
```

And then run the binary:

```
$ ./genai
```
