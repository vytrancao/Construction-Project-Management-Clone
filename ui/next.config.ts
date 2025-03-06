import type { NextConfig } from "next";

const nextConfig: NextConfig = {
  output: 'standalone',
  reactStrictMode: true,
  env: {
    AUTH_SECRET: process.env.AUTH_SECRET,
  }
};

export default nextConfig;