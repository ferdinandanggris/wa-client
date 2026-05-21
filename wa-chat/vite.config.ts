import path from "path"
import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
  plugins: [react()],
  resolve: {
    alias: { "@": path.resolve(__dirname, "./src") },
  },
  server: {
    proxy: {
      '/api': { target: 'http://localhost:9090', changeOrigin: true },
      '/media': { target: 'http://localhost:9090', changeOrigin: true },
      '/ws': { target: 'ws://localhost:9090', ws: true },
      '/ping': { target: 'http://localhost:9090', changeOrigin: true },
    },
  },
})
