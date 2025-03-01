# Rust_Simple

This is an example of submitting a simple prompt for generation in Rust using
the [genai](https://github.com/jeremychone/rust-genai) dependency.

Build it using the `cargo` tool at the command line:

```
$ cargo build
```

After building, the binary should be at `./target/debug/Rust_Simple`
(relative to the project root).

Before running it, make sure that you have the `OPENAI_API_KEY` environment
variable set to a valid OpenAI API key. Then run it like this to generate a joke:

```
$ ./target/debug/Rust_Simple
```
