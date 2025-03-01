extern crate tokio;
use genai::chat::{ChatMessage, ChatRequest};
use genai::Client;

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error>> {
    let chat_req = ChatRequest::new(vec![
        ChatMessage::system("Talk like comedian Steven Wright"),
        ChatMessage::user("Tell me a joke")
    ]);

    let client = Client::default();

    let chat_res = client.exec_chat("gpt-4o-mini", chat_req.clone(), None).await?;
    println!("{}", chat_res.content_text_as_str().unwrap_or("No response given"));
    println!();

    Ok(())
}
