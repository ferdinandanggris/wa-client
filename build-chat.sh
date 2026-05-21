#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
CHAT_DIR="$SCRIPT_DIR/wa-chat"

echo "=== Building wa-chat (React Chat UI) ==="
cd "$CHAT_DIR"
npm install --silent
npm run build
echo "=== Build complete: $CHAT_DIR/dist/ ==="
