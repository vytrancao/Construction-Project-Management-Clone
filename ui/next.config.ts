import type { NextConfig } from "next";

const nextConfig: NextConfig = {
  output: 'standalone',
  reactStrictMode: true,
};

export default nextConfig;

module.exports = {
  env: {
    AUTH_SECRET: process.env.AUTH_SECRET,
  },
}
